using NUnit.Framework;
using playwrightExample.Core.Browser;

namespace playwrightExample.Core.Base
{
public class BaseTest
{
    protected object Driver;

    [SetUp]
    public void SetUp()
    {
        Driver = BrowserManager.InitBrowser("playwright");
    }

    [TearDown]
    public void TearDown()
    {
        // cerrar browser
    }
}
}