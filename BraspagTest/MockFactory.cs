using BraspagTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BraspagTest
{
    public class MockFactory
    {
        public static Customer GetCustomer()
        {
            return new Customer()
            {
                Name = "Tiago Miranda",
                Identity = "12345678909",
                IdentityType = "CPF",
                Email = "comprador@braspag.com.br",
                Birthdate = "1991-01-02",
                Address = new Address()
                {
                    Street = "Alameda Xingu",
                    Number = "512",
                    Complement = "27 andar",
                    ZipCode = "12345987",
                    City = "São Paulo",
                    State = "SP",
                    Country = "BRA",
                    District = "Alphaville"
                },
                DeliveryAddress = new Address()
                {
                    Street = "Alameda Xingu",
                    Number = "512",
                    Complement = "27 andar",
                    ZipCode = "12345987",
                    City = "São Paulo",
                    State = "SP",
                    Country = "BRA",
                    District = "Alphaville"
                },
            };
        }

        public static Payment GetPayment()
        {
            return new Payment()
            {
                Provider = "Simulado",
                Type = "CreditCard",
                Amount = 1000,
                Currency = "BRL",
                Country = "BRA",
                Installments = 1,
                Interest = "ByMerchant",
                Capture = true,
                Authenticate = false,
                Recurrent = false,
                SoftDescriptor = "Mensagem",
                DoSplit = false,
                CreditCard = new CreditCard()
                {
                    CardNumber = "4551870000000181",
                    Holder = "Nome do Portador",
                    ExpirationDate = "12/2021",
                    SecurityCode = "123",
                    Brand = "Visa",
                    SaveCard = "false",
                    Alias = string.Empty
                },
                Credentials = new Credentials()
                {
                    code = "9999999",
                    key = "D8888888",
                    password = "LOJA9999999",
                    username = "#Braspag2018@NOMEDALOJA#",
                    signature = "001"
                },
                ExtraDataCollection = new List<ExtraData>()
                { 
                    new ExtraData(){ Name = "NomeDoCampo", Value = "ValorDoCampo" }
                }

            };
        }
    }
}
