using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using Framework.PageObject;
using Framework.Test;
using Framework.Service;
using Framework.Models;
using log4net;

namespace Framework.Test
{
	public class TestClass : CommonConditions
	{
		[Test]
		public void RentACarWithoutSpecifingAReturnPoint()
		{
			HomePage HomePage = new HomePage(Driver).ClickReturnPointSelectButtom()
													.ClickRentalPointSelect()
													.ClickSelectCarButton();
			Assert.AreEqual("Укажите станцию возврата автомобиля", HomePage.OutpuErrorMessage());
		}

		[Test]
		public void SearchForANonExistentCaBrand()
		{
			HomePage HomePage = new HomePage(Driver).SearchClick()
													.InputNameCar("fdwe")
													.SearchButton();
			Assert.AreEqual("Результатов не найдено", HomePage.ResultsSearch());
		}

		[Test]
		public void ChangeOfLanguageOnSite()
		{
			MainPage mainPage = new MainPage(Driver).ClickLanguageButtonAndSelectLanguage();
			Assert.AreEqual("http://avis.by/en/", mainPage.GetUrlOfMainPageInEnglich());
		}

		[Test]
		public void ContactInformation()
		{
			HomePage HomePage = new HomePage(Driver).ClickContactButton();

			Assert.AreEqual("Контакты", HomePage.ContactInformation());
		}

		[Test]
		public void RentACarWithParameterDefault()
		{
			HomePage HomePage = new HomePage(Driver).ClickReturnPointSelectButtom()
													.ClickRentalPointSelect()
													.ClickSelectCarButton();
			Assert.AreNotEqual("Фильтровать результаты", HomePage.ListCars());
		}
		[Test]
		public void RentCarWithoutEnteringPersonalData()
		{
			MainPage mainPage = new MainPage(Driver)
					.FillInFieldsPickUpAndReturnLocation(LocationCreater.WithOnePoint())
					.ClickGetQuoteButton()
					.ClickPayLaterButton()
					.ClickAcceptRateAndExtrasButton()
					.ClickBookNowButton();
			Assert.AreEqual("Please check the red marked entries.", mainPage.errorMessageWithoutPersonalData.Text);


		}

	}
}