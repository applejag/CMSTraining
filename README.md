# CMSTraining

My personal repository I am using while following through the EPiServer CMS exercise book.

I am doing this on a repository because I have to move between computers, and want to seamlessly continue my schooling.

> ~~**Note to self:** As I've added the localdb to this repo, it includes some accounds.
> For the testing admin account I didn't use the password as instructed in the exercise, but instead Chrome filled out an automatic password for me.~~
>
> ~~Passwords in the testing localdb that follows the repository:  
> `admin`: `C-p5WUZ2DvSNAs!`  
> _the rest_: _same as in the book. for the most part `Pa$$w0rd`_~~
>
> > This got reset in [e5f7537](https://github.com/jilleJr/CMSTraining/commit/e5f7537b59805f167f0893d094ac820eb571a0cc),
> > as now __all__ accounts use `Pa$$w0rd`

Get schooled

## NuGet tips

EPiServer's NuGet packages are a little bit tricky. First off you need to add the following to your NuGet sources:
(Can be found in Visual Studio under `Tools > NuGet Package Manager > Package Manager Settings > Package Sources`)

```
Name: EPiServer NuGet feed
Source: https://nuget.episerver.com/feed/packages.svc/
```

> _`Name` does not have to be exact._

If after cloning the repository your modules/ folder is empty (for either AlloyTraining or AlloyDemo)
then open the `Package Manager Console`, **make sure Package source is set to All** _(in the console)_ and execute the following command to reinstall the packages:

```
Update-Package -Reinstall -ProjectName AlloyDemo
Update-Package -Reinstall -ProjectName AlloyTraining
```

> _The Zip files in the modules folder is added during installation via script and is skipped upon regular NuGet restore._
