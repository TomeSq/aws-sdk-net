/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// This is the response object from the DescribeStreamConsumer operation.
    /// </summary>
    public partial class DescribeStreamConsumerResponse : AmazonWebServiceResponse
    {
        private ConsumerDescription _consumerDescription;

        /// <summary>
        /// Gets and sets the property ConsumerDescription. 
        /// <para>
        /// An object that represents the details of the consumer.
        /// </para>
        /// </summary>
        public ConsumerDescription ConsumerDescription
        {
            get { return this._consumerDescription; }
            set { this._consumerDescription = value; }
        }

        // Check to see if ConsumerDescription property is set
        internal bool IsSetConsumerDescription()
        {
            return this._consumerDescription != null;
        }

    }
}