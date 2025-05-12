using System;

namespace JavaJoke
{
    public class JavaVerboseTranslator : IDisposable
    {
        public string Translate(string input)
        {
            return $"AbstractSingletonProxyFactoryBean{input}ImplementationManagerFactory";
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizacja JavaVerboseTranslator... Uruchamianie Garbage Collectora... Proszę czekać... Nadal czekać...");
        }
    }
}