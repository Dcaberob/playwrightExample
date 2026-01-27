namespace playwrightExample.Core.Browser
{
    public static class BrowserManager
    {
        public static object InitBrowser(string tool)
        {
            return tool.ToLower() switch
            {
                "playwright" => PlaywrightFactory.Create(),
                "selenium" => SeleniumFactory.Create(),
                _ => throw new Exception("Browser tool no soportada")
            };
        }
    }
}
