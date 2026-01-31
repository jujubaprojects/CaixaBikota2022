using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Net;
using System.Threading;

public class WhatsAppSelenium
{
    public static void EnviarMensagem(string pTelefone, string pMensagem)
    {
        string mensagemCodificada = WebUtility.UrlEncode(pMensagem);
        string url = $"https://wa.me/{pTelefone}?text={mensagemCodificada}";


        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        options.AddArgument(@"--user-data-dir=C:\WhatsAppSelenium");

        IWebDriver driver = new ChromeDriver(options);
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

        try
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(10000);

            // 1️⃣ Continuar para WhatsApp Web
            IWebElement btnContinuar = wait.Until(d =>
            {
                var el = d.FindElement(By.XPath("//*[@title='Continuar para o WhatsApp Web']"));
                //var el = d.FindElement(By.Id("action-button"));
                return el.Displayed && el.Enabled ? el : null;
            });
            btnContinuar.Click();

            // 2️⃣ Aguarda carregar WhatsApp Web
            Thread.Sleep(10000);

            // 3️⃣ Botão Enviar
            IWebElement btnEnviar = wait.Until(d =>
            {
                var el = d.FindElement(By.XPath("//button[@aria-label='Enviar']"));
                return el.Displayed && el.Enabled ? el : null;
            });
            btnEnviar.Click();

            Thread.Sleep(3000);
        }
        finally
        {
            driver.Quit();
        }
    }
}
