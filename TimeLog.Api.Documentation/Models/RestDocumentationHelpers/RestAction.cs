﻿using System.Collections.Generic;

namespace TimeLog.Api.Documentation.Models.RestDocumentationHelpers.Core
{
    public class RestAction
    {
        #region Variables

        public string Name { get; }

        public string[] Tags { get; }

        public string Summary { get; }

        public string OperationId { get; }

        public IReadOnlyList<RestParameter> Parameters { get; }

        public IReadOnlyList<RestResponse> Responses { get; }

        public string MethodType { get; }

        #endregion

        #region Constructor

        public RestAction(
            string name,
            string methodType,
            string[] tags,
            string summary,
            string operationId,
            IList<RestParameter> parameters,
            IList<RestResponse> responses
        )
        {
            Name = name;
            MethodType = methodType;
            Tags = tags;
            Summary = summary;
            OperationId = operationId;
            Parameters = new List<RestParameter>(parameters);
            Responses = new List<RestResponse>(responses);
        }

        #endregion
    }
}