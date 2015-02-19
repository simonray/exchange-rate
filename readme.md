#exchange-rate (C#) [![nuget package](https://badge.fury.io/nu/exchange-rate.png)](http://badge.fury.io/nu/exchange-rate.png)

An easy to use exchange-rate checker. Providers include Google, Rate-Exchange and Yahoo.

##Installation

To install, run the following command in the Package Manager Console.

```csharp
Install-Package exchange-rate
```

##Usage

```cs
Provider.Yahoo.Rate(Iso4217.GBP, Iso4217.EUR)
Provider.Google.Rate("GBP", "EUR");
```

##Supported Providers
* [Google Finance](http://www.google.com/finance)
* [Rate Exchange](https://rate-exchange.appspot.com/)
* [Yahoo Finance](https://finance.yahoo.com/)

## Acknowledgements
* [Swap](https://github.com/florianv/swap/)
