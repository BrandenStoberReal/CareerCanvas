using LlmTornado;
using LlmTornado.Code;
using LlmTornado.Code.Models;
using LlmTornado.Models;

#region Models

using LlmTornado.Chat.Models;
using LlmTornado.Chat.Models.DeepInfra;
using LlmTornado.Chat.Models.DeepSeek;
using LlmTornado.Chat.Models.Mistral;
using LlmTornado.Chat.Models.Perplexity;
using LlmTornado.Chat.Models.XAi;
using System.Reflection;

#endregion Models

namespace CareerCanvas.Classes.Static.Utils;

public static class AiUtils
{
    /// <summary>
    /// Internal tornado API class.
    /// </summary>
    private static TornadoApi InternalApi;

    /// <summary>
    /// Currently selected model for AI responses.
    /// </summary>
    private static ChatModel ActiveModel;

    /// <summary>
    /// Represents a dictionary mapping models to their corresponding string identifiers.
    /// </summary>
    /// <remarks>
    /// This dictionary is initialized using the <see cref="ChatModel.AllModelsMap"/> collection,
    /// where the keys are model instances and the values are their associated string identifiers.
    /// </remarks>
    private static Dictionary<IModel, string> ModelMappings = ChatModel.AllModelsMap.ToDictionary(x => x.Value, x => x.Key);

    /// <summary>
    /// Provides a mapping of large language model (LLM) providers to their respective lists of supported models.
    /// </summary>
    /// <remarks>
    /// This dictionary contains predefined associations between LLM providers and the models they
    /// support. Each key represents a specific LLM provider, and the corresponding value is a list of models available
    /// for that provider. This mapping is used to retrieve the available models for a given provider.
    /// </remarks>
    private static Dictionary<LLmProviders, List<IModel>> ProviderModels = new Dictionary<LLmProviders, List<IModel>>
    {
        [LLmProviders.Anthropic] = ChatModelAnthropic.ModelsAll,
        [LLmProviders.Cohere] = ChatModelCohere.ModelsAll,
        [LLmProviders.DeepInfra] = ChatModelDeepInfra.ModelsAll,
        [LLmProviders.DeepSeek] = ChatModelDeepSeek.ModelsAll,
        [LLmProviders.Google] = ChatModelGoogle.ModelsAll,
        [LLmProviders.Groq] = ChatModelGroq.ModelsAll,
        [LLmProviders.Mistral] = ChatModelMistral.ModelsAll,
        [LLmProviders.OpenAi] = ChatModelOpenAi.ModelsAll,
        [LLmProviders.Perplexity] = ChatModelPerplexity.ModelsAll,
        [LLmProviders.XAi] = ChatModelXAi.ModelsAll,
    };

    /// <summary>
    /// Logs in to all available services via API keys.
    /// </summary>
    public static void LoginToApis()
    {
        if (Globals.AiSecrets.ApiKeys.Count == 0)
        {
            Globals.AppLogger.Error("No AI API keys found. Model data cannot be fetched from the APIs.");
            return;
        }

        Globals.AppLogger.Information("Refreshing AI framework authentication & models...");
        try
        {
            List<ProviderAuthentication> F = new List<ProviderAuthentication>();
            F.AddRange(from Tuple<LLmProviders, string> G in Globals.AiSecrets.ApiKeys select new ProviderAuthentication(G.Item1, G.Item2));
            InternalApi = new TornadoApi(F);
            Globals.AppLogger.Information("AI framework successfully authenticated & refreshed.");
        }
        catch (Exception ex)
        {
            Globals.AppLogger.Error(ex, "Failed to refresh AI framework.");
            return;
        }
    }

    /// <summary>
    /// Sets the active model to be used for AI responses.
    /// </summary>
    /// <param name="model"></param>
    public static void SetModel(string model)
    {
        ActiveModel = model;
        Globals.AppLogger.Information("Active AI model set to {Model}", model);
    }

    /// <summary>
    /// Fetches available models from the API.
    /// </summary>
    /// <returns></returns>
    public static List<string> GetAvailableModelsAsStrings()
    {
        if (Globals.AiSecrets.ApiKeys.Count == 0)
        {
            Globals.AppLogger.Error("No AI API keys found. Available models cannot be fetched from the APIs.");
            return new List<string>();
        }

        try
        {
            List<IModel> H = new List<IModel>();
            foreach (LLmProviders I in ProviderModels.Keys)
            {
                if (InternalApi.GetProviderAuthentication(I) != null)
                {
                    H.AddRange(ProviderModels[I]);
                }
            }

            List<string> J = new List<string>();
            J.AddRange(from IModel K in H select ModelMappings[K]);
            return J;
        }
        catch (Exception ex)
        {
            Globals.AppLogger.Error(ex, "Failed to fetch available AI models from the API.");
            return new List<string>();
        }
    }

    /// <summary>
    /// Fetches available models from the API.
    /// </summary>
    /// <param name="provider"></param>
    /// <returns></returns>
    public static List<string> GetAvailableModelsAsStrings(LLmProviders provider)
    {
        if (Globals.AiSecrets.ApiKeys.Count == 0)
        {
            Globals.AppLogger.Error("No AI API keys found. Available models cannot be fetched from the APIs.");
            return new List<string>();
        }

        try
        {
            List<string> J = new List<string>();
            J.AddRange(from IModel K in ProviderModels[provider] select ModelMappings[K]);
            return J;
        }
        catch (Exception ex)
        {
            Globals.AppLogger.Error(ex, "Failed to fetch available AI models from the API for provider {Provider}", provider);
            return new List<string>();
        }
    }

    /// <summary>
    /// Requests a response from the AI service using the specified prompt and message.
    /// </summary>
    /// <param name="prompt"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static async Task<string?> GetResponse(string prompt, string message)
    {
        try
        {
            return await InternalApi.Chat.CreateConversation(ActiveModel)
                .AppendSystemMessage(prompt)
                .AppendUserInput(message)
                .GetResponse();
        }
        catch (Exception ex)
        {
            Globals.AppLogger.Error(ex, "Failed to get AI response for message: {Message}", message);
            return null;
        }
    }
}