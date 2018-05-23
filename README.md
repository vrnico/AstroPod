AstroPod
==========
#### Astrology Web App built in .Net with MySQL

### Epicodus Capstone

#### Description
An astrological community based around the contents of the users natal chart!
***
[![Astropod](https://i.imgur.com/ALFWAaP.gif "Astropod")](https://i.imgur.com/ALFWAaP.gif "Astropod")
***

## Installation (build your own AstroPod!)

#### this setup assumes previous installation of MAMP and Microsoft Visual Studio



Open your preferred terminal, and enter the following command to clone source to your local machine:
```sh
https://github.com/vrnico/astropod.git
```

navigate to the Project directory in AstroPod/AstroPod:
```sh
cd AstroPod
```

restore your dotnet project:
```sh
dotnet restore
```

Generate the database
```
$dotnet ef database update
```
Run program from Visual Studio by pressing ctrl F5 or the play button


Enjoy your brand new AstroPod Database!



## Specifications

1. #### Takes a users input as a user, and generates AstroPod User.

| Input      | Output           |
| ------------- |:-------------:|
| username: vrnico, birthdate: 06/05/1991    | **Sun in Gemini, Moon in Pisces, Mercury in Gemini...** |


2. #### Allows user to login and join contextual astropods

| Input      | Output           |
| ------------- |:-------------:|
| login as vrnico    |you are now logged in as **vrnico**|

3. #### Allows user to login as admin and edit content

| Input      | Output           |
| ------------- |:-------------:|
| edit IMG_1.gif    | vrnico has access to Sun in Gemini AstroPod |

3. #### Allows user to login and comment on their AstroPods

| Input      | Output           |
| ------------- |:-------------:|
| **in sun in gemini:** "whats going on everyeone?"     |**"whats going on everyone?"**|





## features
1. Add/Edit/Delete content as user
2. Comment on content as user
3. Join natal chart specific AstroPods








## Created With
* HTML
* Bootstrap
* CSS
* .NET
* MySQL




## Contact
questions/comments/concerns
* [nico.daunt@gmail.com](mailto:nico.daunt@gmail.com)
* [PERSONAL WEBSITE](http://www.nicodaunt.com)





## License
Copyright 2018


Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
