﻿// Copyright 2017-2018 Dirk Lemstra (https://github.com/dlemstra/line-bot-sdk-dotnet)
//
// Dirk Lemstra licenses this file to you under the Apache License,
// version 2.0 (the "License"); you may not use this file except in compliance
// with the License. You may obtain a copy of the License at:
//
//   https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
// License for the specific language governing permissions and limitations
// under the License.

using System;
using System.Collections.Generic;

namespace Line
{
    internal static class ITemplateActionExtensions
    {
        public static void CheckActionType(this ITemplateAction self)
        {
            if (self is PostbackAction)
                return;

            if (self is MessageAction)
                return;

            if (self is UriAction)
                return;

            throw new NotSupportedException($"The template action type is invalid. Supported types are: {nameof(PostbackAction)}, {nameof(MessageAction)} and {nameof(UriAction)}.");
        }

        public static void Validate(this IEnumerable<ITemplateAction> self)
        {
            foreach (ITemplateAction action in self)
            {
                action.Validate();
            }
        }
    }
}
