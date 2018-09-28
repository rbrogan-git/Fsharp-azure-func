namespace FSharpCosmosFunc
open System.Collections.Generic
open Microsoft.Azure.Documents
open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging

module FSharpCosmosFunc =
        [<FunctionName("FSharpCosmosFunc")>]
        let Run([<CosmosDBTrigger(databaseName="TestDB", collectionName= "TestCol", ConnectionStringSetting = "LocalCosmosDB",LeaseCollectionName = "leases")>] input: IReadOnlyList<Document> , log: ILogger ) =
            log.LogInformation("Documents modified " + string input.Count  )
            log.LogInformation("First document Id " + input.[0].Id)
            