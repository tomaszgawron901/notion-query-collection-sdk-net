using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using Notion.Client;
using Xunit;

namespace Notion.UnitTests;

public class SerializationTests
{
    [Fact]
    public async Task QueryCollectionRequestBodySerializeCorrectly()
    {
        //Arrange
        var jsonData = await File.ReadAllTextAsync("data/queryCollection/QueryCollectionTollsetRequestBody.json");
        jsonData = Regex.Replace(jsonData, @"\s+", "");
        var queryCollectionObject = new QueryCollectionRequestBody
        {
            Collection = new ObjectIdentifier
            {
                id = Guid.Parse("b557bc43-37c4-4a2a-9755-5138551e8b4e"),
                SpaceId = Guid.Parse("e7f78a14-0bfc-463c-ada0-a6846f57e66a")
            },
            CollectionView = new ObjectIdentifier
            {
                id = Guid.Parse("1d00f7d0-ec16-49d5-8387-074b4a9445d2"),
                SpaceId = Guid.Parse("e7f78a14-0bfc-463c-ada0-a6846f57e66a")
            },
            Loader = new ReducerLoader
            {
                Reducers = new Dictionary<string, IReducer>
                {
                    { "collection_group_results",
                        new ResultReducer
                        {
                            Limit = 10
                        }
                    }
                }
            }
        };

        //Act
        var serializedObject = JsonConvert.SerializeObject(queryCollectionObject);

        //Assert
        serializedObject.Should().BeEquivalentTo(jsonData);
    }
}
