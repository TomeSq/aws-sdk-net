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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Information about a frame metric and its values.
    /// </summary>
    public partial class FrameMetricDatum
    {
        private FrameMetric _frameMetric;
        private List<double> _values = new List<double>();

        /// <summary>
        /// Gets and sets the property FrameMetric.
        /// </summary>
        [AWSProperty(Required=true)]
        public FrameMetric FrameMetric
        {
            get { return this._frameMetric; }
            set { this._frameMetric = value; }
        }

        // Check to see if FrameMetric property is set
        internal bool IsSetFrameMetric()
        {
            return this._frameMetric != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        ///  A list of values that are associated with a frame metric. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<double> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}