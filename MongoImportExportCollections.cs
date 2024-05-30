using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBTool
{
    internal class MongoImportExportCollections
    {
        public bool ExportAllCollectionsToJSON(string connectionString, string databaseName, string outputDirectory)
        {
            bool ExportStatus = true;
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            var collections = database.ListCollectionNames().ToList();

            // Ensure output directory exists
            Directory.CreateDirectory(outputDirectory);

            try
            {
                foreach (var collectionName in collections)
                {
                    var collection = database.GetCollection<BsonDocument>(collectionName);
                    // Retrieve all documents from the collection
                    var documents = collection.Find(new BsonDocument()).ToList();

                    // Convert BsonDocument list to JArray
                    var jsonArray = new JArray();
                    foreach (var document in documents)
                    {
                        //Proper way to convert BsonDocument to JSON with format retained. 
                        var jsonWritersetting = new JsonWriterSettings { OutputMode = JsonOutputMode.CanonicalExtendedJson };
                        JObject json = JObject.Parse(document.ToJson<MongoDB.Bson.BsonDocument>(jsonWritersetting));
                        jsonArray.Add(json);
                    }

                    var filePath = Path.Combine(outputDirectory, $"{collectionName}.json");
                    File.WriteAllText(filePath, jsonArray.ToString());

                }
            }
            catch (Exception ex)
            {
                ExportStatus = false;
                //throw ;
                //Log the error here. 
            }
            finally
            {
                if (ExportStatus)
                {
                    Console.WriteLine("Exported all collections to JSON successfully");
                }
                else
                {
                    Console.WriteLine("Export failed for one of many collections.");
                }
            }
            return ExportStatus;
        }

        public bool ImportJSONFilesToCollections(string connectionString, string databaseName, string inputDirectory)
        {
            bool ImportStatus = true;
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            // Get all JSON files in the input directory
            var jsonFiles = Directory.GetFiles(inputDirectory, "*.json");

            try
            {
                foreach (var jsonFile in jsonFiles)
                {
                    // Read the JSON file contents
                    var json = File.ReadAllText(jsonFile);

                    // Get the collection name from the file name
                    var collectionName = Path.GetFileNameWithoutExtension(jsonFile);

                    // Deserialize the JSON into a list of BsonDocuments
                    var documents = BsonSerializer.Deserialize<List<BsonDocument>>(json);

                    // Get the collection and insert the documents
                    var collection = database.GetCollection<BsonDocument>(collectionName);
                    collection.InsertMany(documents);

                }
            }
            catch (Exception ex)
            {
                ImportStatus = false;
                //throw;
                //Log the error here. 
            }
            finally
            {
                if (ImportStatus)
                {
                    Console.WriteLine("Imported all JSON files to collections successfully");
                }
                else
                {
                    Console.WriteLine("Import failed for one of many JSON files.");
                }
            }
            return ImportStatus;
        }

    }
}
