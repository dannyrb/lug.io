
### Win Environment 1st Time Setup
[DNVM, DNX, and DNU - Understanding the ASP.NET 5 Runtime Options](http://www.codeproject.com/Articles/1005145/DNVM-DNX-and-DNU-Understanding-the-ASP-NET-Runtime)

1. PowerShell Command to install DNVM (dotnet version manager):
`&{$Branch=’dev’;iex ((new-object net.webclient).DownloadString (‘https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1‘))}`
    - Type the `dnvm` command to verify that it was installed

2. Gain access to DNX and DNU commands: 
`dnvm install latest`

3. To show installed runtimes (* next to default):
`dnvm list`

Other Helpful commands:
`dnvm upgrade`
`dnvm update-self`

To See Entity Framework commands:
`dnx ef` in "Domain" project folder

http://stackoverflow.com/questions/30851344/how-can-i-do-an-entity-framework-core-project-and-add-a-migration-in-visual-stud