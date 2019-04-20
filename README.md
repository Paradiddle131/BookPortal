# BookPortal

To run the project without SQL error: 
- Double click ReviewDB.publish.xml which is located in ReviewDB -> Publish Profiles under Solution Explorer
- Click "Publish" button on the pop-up form

If your localdb name is different from "MSSQLLocalDB", then you need to find your specific connection string:

- Open SQL Server Object Explorer (can be opened via using Quick Launch (Ctrl+Q))
- SQL Server -> (localdb)\MSSQLLocalDB -> Databases -> ReviewDB
- Right click ReviewDB
- Properties
- Copy Connection string
- Paste it between your "connectionStrings" tags located in Web.config file
