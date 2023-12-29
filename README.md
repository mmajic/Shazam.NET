# Shazam.NET

A .NET library being built to wrap the RapidAPI shazam API.

## Description

The Shazam API Wrapper Library serves as a bridge between developers and the robust capabilities of Shazam's music recognition API, facilitating seamless integration via RapidAPI. This project aims to simplify the complex process of audio identification, enabling effortless retrieval of comprehensive song metadata within diverse applications. By leveraging this library, developers can easily implement audio fingerprinting and recognition functionalities, allowing users to submit audio samples and obtain accurate details about identified songs, including titles, artists, albums, release years, and more. The library provides a user-friendly interface, empowering developers to customize queries, fine-tune search parameters, and handle errors efficiently. Whether building music discovery apps, enhancing user experiences in social platforms, or incorporating music identification features into various applications, this library streamlines the integration process, saving valuable time and effort. The comprehensive documentation, coupled with RapidAPI's secure authentication, ensures a smooth implementation process for developers of all levels. Ultimately, the Shazam API Wrapper Library elevates applications by seamlessly integrating Shazam's powerful music recognition capabilities, providing a simple yet robust solution for accurate and effortless music identification.

## Getting Started

### Dependencies

* Windows 10/11
* Visual Studio 2019 or newer
* .NET 8
* Microsoft.Extensions.DependencyInjection

### Usage
You need to inject the Shazam services within your program.cs file
```
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddShazam("YOUR-API-KEY");
// other services...
```


## Help/Feature Requests

Open a new github issue

## Contributions
Contributions are welcome

## Authors
[Mateo Majic](https://www.linkedin.com/in/mmajic/)

## Version History

No releases have been published

## License

This project is licensed under the MIT License - see the LICENSE.md file for details
