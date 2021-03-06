﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using JOSHttpClient.Common;
using Newtonsoft.Json;

namespace JOSHttpClient.Version0
{
    public class GitHubClient
    {
        public IReadOnlyCollection<GitHubRepositoryDto> GetRepositories()
        {
            using (var httpClient = new HttpClient{BaseAddress = new Uri(GitHubConstants.ApiBaseUrl)})
            {
                var result = httpClient.GetStringAsync(GitHubConstants.RepositoriesPath).Result;
                return JsonConvert.DeserializeObject<List<GitHubRepositoryDto>>(result);
            }
        }
    }
}
