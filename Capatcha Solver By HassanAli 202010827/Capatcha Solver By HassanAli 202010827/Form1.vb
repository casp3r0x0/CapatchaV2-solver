'Date       : 2020/30/11
'Auther     : Hassan Ali 202010827 
'Facebook   : https://www.facebook.com/profile.php?id=100022030244215 
'This  is program made  to  prove that Capatcha v2 is easy  to bypass  
Imports System.Text
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Interactions
Imports OpenQA.Selenium.Support.UI
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim driver As IWebDriver
        Dim options As New ChromeOptions
        options.AddExtension(Application.StartupPath & "\buster.crx")
        driver = New ChromeDriver(options)
        driver.Navigate().GoToUrl("https://www.google.com/recaptcha/api2/demo")
        Dim element As IWebElement = driver.FindElement(By.XPath("//*[@id='recaptcha-demo']"))
        element.Click()
        System.Threading.Thread.Sleep(3000)
        driver.SwitchTo().Frame(0)
        SendKeys.Send("{TAB}")
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.facebook.com/profile.php?id=100022030244215")
    End Sub
End Class
