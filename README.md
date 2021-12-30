# AllSeer

[![.NET](https://github.com/jorelius/AllSeer/actions/workflows/dotnet.yml/badge.svg)](https://github.com/jorelius/AllSeer/actions/workflows/dotnet.yml)
[![CodeQL](https://github.com/jorelius/AllSeer/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/jorelius/AllSeer/actions/workflows/codeql-analysis.yml)

## Purpose

To make searching images as easy as grepping text files. This tool supports extracting predictions and generating output images with prediction markup.

<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

* [.NET 6 SDK or later](https://dotnet.microsoft.com/en-us/download)

### Installation

#### Global tool

* Install [.NET 6 SDK or later](https://dotnet.microsoft.com/en-us/download)
* dotnet tool install --global allseer

#### Self Contained

TBD

## Usage

Allseer CLI, or allseer, is a command-line tool for generating classification predictions for images. You can filter prediction labels and create images with prediction bounding boxes and markup.

> Basic help can be had by "allseer -?"

![Basic Help](https://raw.githubusercontent.com/jorelius/AllSeer/main/docs/cli-help.jpg)

> 

<!-- ROADMAP -->
## ROADMAP

- [X] Add automated tool / nuget package building
- [ ] Add Configurable Model and Weights
- [X] Support downloading model
- [X] Cross platform support (linux, osx, windows)
- [X] Support filtering images and predictions by labels
- [ ] Support extracting text from images
- [ ] Build platform / architecture specific self contained binaries (linux, windows, osx / x64, x32, ARM, etc)

Pull requests are more than welcomed!

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>

## License

Usage is provided under the [MIT License](http://http//opensource.org/licenses/mit-license.php). See LICENSE for the full details.

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [PowerArgs](https://github.com/adamabdelhamed/PowerArgs)
* [Yolov5Net](https://github.com/HTTP123-A/HumanDetection_Yolov5NET)
