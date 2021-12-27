# AllSeer

[![.NET](https://github.com/jorelius/AllSeer/actions/workflows/dotnet.yml/badge.svg)](https://github.com/jorelius/AllSeer/actions/workflows/dotnet.yml)
[![CodeQL](https://github.com/jorelius/AllSeer/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/jorelius/AllSeer/actions/workflows/codeql-analysis.yml)

## Purpose

To make searching images as easy as grepping text files. This tool supports extracting predictions and generating output images with prediction markup.

## Quick start

### Global tool

* Install [.NET 6 SDK or later](https://dotnet.microsoft.com/en-us/download)
* dotnet tool install --global allseer

### Self Contained

TBD

## Usage

Allseer CLI, or allseer, is a command-line tool for generating classification predictions for images. You can filter prediction labels and create images with prediction bounding boxes and markup.

> Basic help can be had by "allseer -?"

![Basic Help](/docs/cli-help.jpg)

## Development

### Prerequisites

* [.NET 6 SDK or later](https://dotnet.microsoft.com/en-us/download)

### Todo

- [X] Add automated tool / nuget package building
- [ ] Add Configurable Model and Weights
- [ ] Support downloading model and weights
- [X] Cross platform support (linux, osx, windows)
- [X] Support filtering images and predictions by labels
- [ ] Support extracting text from images
- [ ] Build platform / architecture specific self contained binaries (linux, windows, osx / x64, x32, ARM, etc)

Pull requests are more than welcomed!

## License

Usage is provided under the [MIT License](http://http//opensource.org/licenses/mit-license.php). See LICENSE for the full details.
