using LlmTornado;
using LlmTornado.Code;

namespace CareerCanvas.Classes.Static.Utils;

public static class A
{
    private static TornadoApi B;

    public static void RefreshApis()
    {
        List<ProviderAuthentication> auths = [];
        auths.AddRange(from Tuple<LLmProviders, string> auth in Globals.AiSecrets.ApiKeys select new ProviderAuthentication(auth.Item1, auth.Item2));
        B = new TornadoApi(auths);
    }
}