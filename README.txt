2024-05-09 1631
Vinay Kumar Chepuri
Web application  w/ VS2022 .NET 7
no auth, .....
SSL cert SH-1

1530

Tested and modified the app....
All good

1620

Part 2

Added a controller. Have tested two different controller methods and confirmed by running the app in browser, got output.

2024-05-16

1400

Part 3

Added a view, created a folder and named HelloWorld under view. 

Added a New item in Hello World, that is Razor View - Empty, Name box value- Index.cshtml.   

1430

Created a newfolder in views 
name: HelloWorld
added a new item razor view empty, opened the index html file
I tried testing the webpage 

1500

All are running successfully 
urls tested:
https://localhost:7090/
https://localhost:7090/HelloWorld
https://localhost:7090/HelloWorld/Welcome
https://localhost:7090/HelloWorld/HaveANiceDay
https://localhost:7090/HelloWorld/Welcome/3000?name=King
https://localhost:7090/HelloWorld/Raju?name=Vinni&ID=123

202405231500

1525

https://localhost:7090/Home/Privacy
Successfully got Privacy Policy
https://localhost:7090/HelloWorld/Welcome?name=Vinni&numtimes=4

1540

Part 4

Added a data model class
name=Movie.cs

Add NuGet packages
First i was unable to add new scafflod item then i recognized the issue that was to stop the run and then i could find the add scafflod item and i have added it
as per the instructions

In the Package Manager Console (PMC) i have given the code to add migration and update the database
Then i have run the app and selected the Movie App link
I got the required output

Created a Migration file - 20240530190503_InitialCreate

2024-05-30

1510

Part 5

Worked with SQL data base editor and examined the values given is updated as given in the browser.Verified the 
gap between the Release and date in the browser and corrected it in the program.cs file.

Part 6

Examined the controller methods and views.Checked the Edit URL link and verified with unknown data so that it gives
the error message that means it is controlling the app.
https://localhost:7019/Movies/Edit

2024-06-06

1400

Part 7

I've added UI element to help filter movies. I felt happy that i have managed to create a search filter.
Added and updated MovieGenreViewModel class to the Models folder.

1415

Replaced the Index method in MoviesController.cs with the given code, first i got some error:(
to check MovieGenreViewModel class and MoviesController class.

By trying and trying, somehow i figured out the solution and got Index page back. Funny..:)

1430

Updated Index.cshtml in Views/Movies to add search by genre

Hurray..I got the search by genre bar

Part 8

1439

Added a Rating property to Models/Movie.cs

Did some edits in the /Views/Movies/Index.cshtml file and added a Rating field

Updated the /Views/Movies/Create.cshtml with a Rating field as well.
and updated the SeedData class so that it provides a value for the new column

After this the app didn't work :( 
Showing as  SqlException: Invalid column name 'Rating'

Now in Package Manager Controller by adding migration rating, Updated the Database.

Finally..:) Got the Rating column 

20240606190134_Rating

Part 9

1510

validation rules for movie model

For data types, I validated the UI with possible inputs
Test successful, Noticed how the form has automatically rendered an appropriate
validation error message in each field containing an invalid value. 

Part 10

Examined the movie controller
Examined the program.cs files

1530

Created the Github account 
Cloned it in VS22
Pushed project 'MvcMovie' to github
Made my github repository private to public 
Done checking with my friend to access my github link..its working..

Thank you..
