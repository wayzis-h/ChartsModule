# Charts module
*Open-source trades data storage service.*

The WEB-API has built on .NET Core using C# and ASP.NET Core.
These technologies were chosen because of portability and personal familiarity with them.

In near future we expect adding basic functional of a storage API:
- A method that produces a sequence of bars depending on time intervals;
- Methods to add new trade data in the database.

Additional objectives:
- Queue broker support;
- Study of Docker.

# How to use
First you need Visual Studio 2022.
Then you can install [Docker Desktop for Windows](https://github.com/docker/for-win) or use your preferable edition.
This should be enought to compile and run the program.

You can explore the API through Swagger UI on *https://hostname:port/swagger*.

# Credits
The WEB-API developed by [Anatoly Kostin](https://github.com/wayzis-h).
The external system designed by [Nikolay](https://github.com/TeslaSesla).

# License
This repository is licensed under the [GNU Affero General Public License v3.0](https://www.gnu.org/licenses/agpl-3.0.html).
So you can use, modify and distribute it for your own purposes, but your source code must be available to any user and include notice of the license and copyright.
