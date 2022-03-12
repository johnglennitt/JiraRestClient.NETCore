using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Cschulc.Jira.Jql;

namespace JiraRestClient.Net.Jql
{
    public class JqlSearchBean
    {
        /**
         * Result list start at.
         */
        [JsonPropertyName("startAt")]
        public int StartAt { get; set; }

        /**
         * Maximum result list size.
         */
        [JsonPropertyName("maxResults")]
        public int MaxResults { get; set; }

        /**
         * Result fields for a query.
         */
        public readonly List<string> fields = new List<string>();

        [JsonPropertyName("jql")]
        public string Jql { get; set; }

        [JsonPropertyName("expand")]
        public readonly List<string> Expand = new List<string>();


        public JqlSearchBean()
        {
            StartAt = 0;
            MaxResults = 50;
        }

        /**
         * Adds fields which should be returned after the request.
         *
         * @param fields = returned fields
         */
        public void AddField(params EField[] efields)
        {
            foreach (var element in efields)
            {
                fields.Add(element.ToString());
            }
        }

        public void AddExpand(params EField[] efields)
        {
            foreach (var element in efields)
            {
                Expand.Add(element.ToString());
            }
        }

    }
}
