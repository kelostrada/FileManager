FileManager
===========

A simple library for object serialization in XML

Examples
===========

Serializing:

    var settings = new Settings { AccountList = new List<Account> { new Account { Username = "test", Password = "123qwe" } } };
    FileManager.FileManager.Serialize<Settings>("settings.xml", settings);

Deserializing:

    var settings = FileManager.FileManager.Deserialize<Settings>("settings.xml");

Nuget
===========
https://www.nuget.org/packages/FileManager.dll/
