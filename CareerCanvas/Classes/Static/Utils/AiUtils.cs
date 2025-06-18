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

#endregion Models

namespace CareerCanvas.Classes.Static.Utils;

public static class AiUtils
{
    private static TornadoApi B;

    private static Dictionary<LLmProviders, List<IModel>> C = new Dictionary<LLmProviders, List<IModel>>
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

    private static ChatModel D;

    private static Dictionary<IModel, string> E = ChatModel.AllModelsMap.ToDictionary(x => x.Value, x => x.Key);

    public static void RefreshApis()
    {
        List<ProviderAuthentication> F = [];
        F.AddRange(from Tuple<LLmProviders, string> G in Globals.AiSecrets.ApiKeys select new ProviderAuthentication(G.Item1, G.Item2));
        B = new TornadoApi(F);
    }

    public static string[] GetAvailableModels()
    {
        List<IModel> H = [];
        foreach (LLmProviders I in C.Keys)
        {
            if (B.GetProviderAuthentication(I) != null)
            {
                H.AddRange(C[I]);
            }
        }

        List<string> J = [];
        J.AddRange(from IModel K in H select E[K]);
        return J.ToArray();
    }

    public static string[] GetAvailableModels(LLmProviders provider)
    {
        List<string> J = [];
        J.AddRange(from IModel K in C[provider] select E[K]);
        return J.ToArray();
    }

    public static void SetModel(string model)
    {
        D = model;
    }

    public static async Task<string?> GetResponse(string prompt, string message)
    {
        return await B.Chat.CreateConversation(D)
            .AppendSystemMessage(prompt)
            .AppendUserInput(message)
            .GetResponse();
    }
}