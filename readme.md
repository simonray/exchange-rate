#exchange-rate (C#) [![nuget package](https://img.shields.io/nuget/v/exchange-rate.png?style=flat-square)](https://www.nuget.org/profiles/simonray)

An easy to use exchange-rate checker and converter. Providers include Google, Rate-Exchange and Yahoo.

##Installation

To install, run the following command in the Package Manager Console.

```csharp
Install-Package exchange-rate
```

##Usage

```cs
using ExchangeRate;
Provider.Yahoo.Rate(Iso4217.GBP, Iso4217.EUR)
Provider.Google.Rate("GBP", "EUR");
Provider.Google.Convert(Iso4217.GBP, Iso4217.EUR, 500);
```

##Supported Providers
* [Google Finance](http://www.google.com/finance)
* [Rate Exchange](https://rate-exchange.appspot.com/)
* [Yahoo Finance](https://finance.yahoo.com/)

## Change Log

#### 1.0.3 (11-03-15)
* Support for value conversion.
#### 1.0.2 (24-02-15)
* Shorten namespaces.
#### 1.0.1 (24-02-15)
* Add support for ISO4217 codes.
#### 1.0.0 (23-02-15)
* Initial release.

## Acknowledgements
* [Swap](https://github.com/florianv/swap/)
