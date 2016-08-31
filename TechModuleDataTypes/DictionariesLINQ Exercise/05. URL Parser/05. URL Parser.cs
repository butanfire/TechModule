namespace _05.URL_Parser
{
    using System;

    public class URLParser
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string protocolSeparator = "://";
            string resourceSeparator = "/";
            string protocol = "";
            string server;
            string resource = "";

            int indexProtocol = input.IndexOf("://");
            int indexResource = input.IndexOf("/", indexProtocol + protocolSeparator.Length);
            if (indexProtocol != -1)
            {
                //found 
                protocol = input.Substring(0, indexProtocol);
                server = indexResource == -1 ? 
                    input.Substring(indexProtocol + protocolSeparator.Length, input.Length - indexProtocol - protocolSeparator.Length) : 
                    input.Substring(indexProtocol + protocolSeparator.Length, indexResource - protocol.Length - protocolSeparator.Length);
            }
            else
            {
                server = indexResource == -1 ? 
                    input.Substring(0, input.Length) : 
                    input.Substring(indexProtocol + protocolSeparator.Length, indexResource - protocol.Length - protocolSeparator.Length);
            }
            if (indexResource != -1)
            {
                resource = input.Substring(indexResource + resourceSeparator.Length, input.Length - indexResource - resourceSeparator.Length);
            }

            Console.WriteLine("[protocol] = \"{0}\"\n[server] = \"{1}\"\n[resource] = \"{2}\"",protocol,server,resource);
        }
    }
}
