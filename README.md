# C# Entity Framework Intro

1. Fork this repository
2. Clone your fork to your machine
3. Open the ef.intro.sln in Visual Studio
4. Only write code in the LibraryRepository.cs.  Finish all methods, replacing "throw new NotImplementedException();" with 
   relevant LibraryContext code.  
5. Note:  There are no controllers in this project!!  A current way of writing endpoints is in the EndPoint directory.
		  See How the AuthorApi.cs & BookApi.cs both are extension methods of the WebApplication class which 
		  is returned in the Program.cs from a builder.Build() call.  This way we can call this to initialize from the 
		  extension method.  See also how the data is populated via the Seed() method call.  Note how we are 
		  randomly generating names of both authors & books!



# .http Files

As you can see from http files, they contain a list of verbs and a green 'play' button on the left. (in VS Code this is slightly different)
