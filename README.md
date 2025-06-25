# The Crimson Jade Chronicles

This is a project to demonstrate a TDD workflow using Unreal Engine.

## Building and Running the Project

You need a source-code build of Unreal Engine 5.6 or later to build this
project. Neither the launcher version nor an installed build will currently
work, since they lack the low-level test framework and cannot compile the unit
tests, which are set up as separate program.

To register your UE5 source build under the correct key on Windows, open the
registry editor and navigate to

```
Computer\HKEY_CURRENT_USER\Software\Epic Games\Unreal Engine\Builds
```

Add a new string value with key `ue5-cj` and add the path to the UE5 git
repository as value (or replace the existing key for this installation with
`ue5-cj` if you don't have any other projects using that engine version).

To open the editor, open the `CrimsonJade.sln` file in Visual Studio or Rider
and run the `CrimsonJade` target. Run target `CrimsonJadeUnitTests` to execute
the unit tests. You don't need to build or run the editor for this.

Note that opening the project as Rider `.uproject` will currently not work, at
least if you want to run the unit tests, which is the whole purpose for this
project. Rider does not seem to recognize the `CrimsonJadeUnitTests` target,
therefore you cannot compile or run the unit tests from Rider in this
configuration.
