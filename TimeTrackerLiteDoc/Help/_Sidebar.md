- [Welcome to the [TODO: Add project name]](b56657ef-3f3b-444d-b052-b37a808222c1)
- [Version History](b862547d-0cd1-4aa2-89d3-678c8a336eba)
  - [Version 1.0.0.0](1a966554-d30a-4562-abbf-2080d4a61948)
- [TimeTrackerLite Namespace](8c0126d1-b10d-7d5a-9e92-4885dee37eb2)
  - [Program Class](cf419fe5-354c-d2ec-ddc8-0f86d01ad6f3)
    - [Program Constructor](35b3d40b-8ada-7fb2-0572-b680db33df8a)
    - [Program Methods](8c3f0fb6-69af-67b9-f74d-8f54bc5778d7)
      - [Program.BuildWebHost Method](98f6e1c1-a63c-89dd-7e62-31855deaed2c)
      - [Program.Main Method](f00d9816-6e71-abd0-e9c5-4df34d7a2c8e)
  - [Startup Class](49846983-c4e6-f4fb-a81c-5ecd758088da)
    - [Startup Constructor](5395624f-cb3f-5275-a64b-41302eeac963)
    - [Startup Properties](353e0c1c-3a96-7201-057a-3216010b2713)
      - [Startup.Configuration Property](8b59723b-de90-924e-9d52-6ac612014bdf)
      - [Startup.DBSettings Property](50285af0-5bcc-3429-4670-7e3119bb5d99)
    - [Startup Methods](2cf48a6f-9516-0acf-bb11-7a2c7589e8b9)
      - [Startup.Configure Method](1fdea499-1fe9-b633-38d0-b33284735918)
      - [Startup.ConfigureServices Method](ab5904d3-eaf6-6407-d56a-c3a9c1041a73)
- [TimeTrackerLite.Data Namespace](ab3f657c-6df0-d665-b9bf-c166a389ec06)
  - [ConnectionStringSettings Class](7073fccb-fb2a-570f-2616-4a4f9345cb39)
    - [ConnectionStringSettings Constructor](0b4c5d5a-e784-1a76-4862-c2efce0a2437)
    - [ConnectionStringSettings Properties](6d6dc903-7130-6f40-8e5f-fb7592709db8)
      - [ConnectionStringSettings.ConnectionString Property](e1999ee6-b89f-e7b0-c5e4-6ba9233dca42)
      - [ConnectionStringSettings.IsGlobal Property](7b79d958-6395-baff-37c2-8b54aa7f0188)
      - [ConnectionStringSettings.Name Property](7af15bf9-20f5-6457-4065-061f7161a12c)
      - [ConnectionStringSettings.ProviderName Property](2ee770a3-01e9-2639-b1cd-ae9e30e0c8a4)
    - [ConnectionStringSettings Methods](227f5418-8136-2b70-eab6-9d087494260f)
  - [DbConnectionSettings Class](937631b1-2b2d-69c8-66bf-e9d357456481)
    - [DbConnectionSettings Constructor](008acf86-42af-6beb-5e83-b4ce988ef89d)
    - [DbConnectionSettings Properties](26621a75-ac01-b8a6-9c17-b32b7b12a85f)
      - [DbConnectionSettings.ConnectionStrings Property](385b0123-190e-d365-e3ed-73739c407476)
      - [DbConnectionSettings.DataProviders Property](6b2de54a-2314-2b21-8b31-6f0b2879590a)
      - [DbConnectionSettings.DefaultConfiguration Property](eed0a554-8508-1bd1-7193-9e59f470c26d)
      - [DbConnectionSettings.DefaultDataProvider Property](7087819f-d664-6c9e-8748-d5c15ac555b1)
    - [DbConnectionSettings Methods](b3938fb1-0335-287c-3e5e-50f503942219)
  - [DBSettings Class](05da7135-f4b0-1ba0-42f4-3e9b1cc914fa)
    - [DBSettings Constructor](35a39418-aa29-0c9b-d3cd-f3e646877cbd)
    - [DBSettings Properties](9bba0a6b-b7d6-9f73-9eac-eacc188b1ffa)
      - [DBSettings.Database Property](f3164456-e3f3-35b7-fd48-66a74b15ef32)
      - [DBSettings.DBPassword Property](a4298f0a-cecb-3018-6b55-bc01294e391f)
      - [DBSettings.DBUserName Property](b900c2db-fc29-4798-9552-fd1f45eb0a59)
      - [DBSettings.Port Property](0840a14c-a15b-f36b-0722-cddd3883038c)
      - [DBSettings.Server Property](c9b1b44c-761e-bdda-d23c-12086831458f)
    - [DBSettings Methods](a4b1d918-18ff-6960-049b-193ec397271f)
      - [DBSettings.FromConnectionsString Method](5f707ed5-c5dc-6fdf-5000-351eb239ca10)
      - [DBSettings.ToDBConnectionString Method](b4919d4f-1972-d458-1774-49a63ded02ce)
  - [MappingLinq2Db Class](ea7df6da-9c8b-3d31-4604-e7a625f5e16b)
    - [MappingLinq2Db Methods](462c599a-e372-a272-8f9d-41342cdb1b87)
      - [MappingLinq2Db.Do Method](a535ccd5-cd7e-5b80-7f64-bdd8f2852d48)
- [TimeTrackerLite.Pages Namespace](be72919d-3e91-d5db-2c88-41279e953f1c)
  - [AboutModel Class](bfed49df-4190-ef8c-46ac-7a1943864414)
    - [AboutModel Constructor](bc5ece06-62a0-3947-de35-a65516f9ebec)
    - [AboutModel Properties](1c79c26f-abca-faa3-4ae9-318141a35f37)
      - [AboutModel.Message Property](dfd83958-0668-37a4-0cfd-e1c794b19089)
    - [AboutModel Methods](4a17841f-c227-c7d0-64f9-9784239a7bb7)
      - [AboutModel.OnGet Method](ec7eaebc-f4b2-d32d-176f-19c58b1eea7c)
  - [ContactModel Class](3c268f5d-3c19-5116-b3e7-f8496783a58a)
    - [ContactModel Constructor](ca8680d6-1af2-9f55-4dd3-1b50e8203756)
    - [ContactModel Properties](1d3d6f1d-ba8c-c058-0f4e-bac40de1974d)
      - [ContactModel.Message Property](a6262398-e325-a2d3-2c80-4ca34a4f718e)
    - [ContactModel Methods](5c518eeb-40ca-2c27-cd92-672acfa835ef)
      - [ContactModel.OnGet Method](6d11cf82-4d49-10b9-83f9-1f53fc7618ca)
  - [ErrorModel Class](e880ddaf-8452-5024-9ccc-b43250dbd15b)
    - [ErrorModel Constructor](efc6de89-1020-5e65-9086-1b7cacfd5056)
    - [ErrorModel Properties](451ef8b1-42b1-d4a5-ce8c-05e7da59e742)
      - [ErrorModel.RequestId Property](46aaf116-2c8b-9bea-9228-16f4f88aa146)
      - [ErrorModel.ShowRequestId Property](f33d1561-2a97-ae1e-40e5-24754a493428)
    - [ErrorModel Methods](e9ee0fb9-a042-7815-34a5-83e1079b7001)
      - [ErrorModel.OnGet Method](783c71ac-ebd7-7500-a678-e07b4e34a806)
  - [IndexModel Class](1d8b1b83-2045-aba1-54d2-9d7d03526738)
    - [IndexModel Constructor](735d51f2-0d8a-55fa-673a-38f9586b36ea)
    - [IndexModel Methods](6b7bdae0-1ae9-bbf7-ff38-ca98e23e83de)
      - [IndexModel.OnGet Method](b89f08be-e14f-62cf-a4e8-43cc58f18a86)