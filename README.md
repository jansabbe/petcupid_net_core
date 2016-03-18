[![Stories in Ready](https://badge.waffle.io/jansabbe/petcupid_net_core.png?label=ready&title=Ready)](https://waffle.io/jansabbe/petcupid_net_core)

# petcupid_net_core
PetCupid using .Net Core and Typescript

# Goals

* I want to learn more about the new open-source stack from Microsoft, and check if I can develop without Windows in practice.
* I want to compare working with ReactJS instead of AngularJS
* I want a typesafe UI by using TypeScript

# Documentation/Links

[.Net Core](https://dotnet.github.io/)
[Visual Studio Code](https://code.visualstudio.com)

# Random notes while installing/setting up project

* After install, make sure `/usr/local/share/dotnet/bin` is in your PATH
* Need latest openssl installed (`brew update` && `brew install openssl`)
* Ensure homebrew has been installed in the default location!

* The latest dotnet core RC version apparently does not work with the latest asp.net RC. Documentation not really up to date.

* Other install instructions: [ASP.NET](https://docs.asp.net/en/latest/getting-started/installing-on-mac.html). Still uses dnx/dnvm commands instead of dotnet cli.

* To get autocompletion working, make sure you ran `dnvm upgrade -r mono`. 
* To get watcher running `dnu commands install Microsoft.Dnx.Watcher`
* Did not work.
	Alternatively http://johnpapa.net/automatically-restarting-asp-net-on-osx-with-dnxmon/


# Webpack

* [ASP.NET + Webpack](http://xabikos.com/javascript%20module%20bundler/javascript%20dependencies%20management/css%20module%20bundler/css%20dependencies%20management/2015/12/15/asp.net-5-and-webpack-part-1.html)
* [Boilerplate example](https://github.com/xabikos/aspnet5-react-webpack-boilerplate)

# Typescript

* `npm install -g tsd`