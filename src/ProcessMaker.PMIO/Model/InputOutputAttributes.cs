/* 
 * ProcessMaker API
 *
 * This ProcessMaker I/O API provides access to a BPMN 2.0 compliant workflow engine api that is designed to be used as a microservice to support enterprise cloud applications.  The current Alpha 1.0 version supports most of the descriptive class of the BPMN 2.0 specification.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@processmaker.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ProcessMaker.PMIO.Model
{
    /// <summary>
    /// InputOutputAttributes
    /// </summary>
    [DataContract]
    public partial class InputOutputAttributes :  IEquatable<InputOutputAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputOutputAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputOutputAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputOutputAttributes" /> class.
        /// </summary>
        /// <param name="InputParameters">InputParameters (required).</param>
        /// <param name="OutputParameters">OutputParameters (required).</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public InputOutputAttributes(Object InputParameters = null, Object OutputParameters = null, string CreatedAt = null, string UpdatedAt = null)
        {
            // to ensure "InputParameters" is required (not null)
            if (InputParameters == null)
            {
                throw new InvalidDataException("InputParameters is a required property for InputOutputAttributes and cannot be null");
            }
            else
            {
                this.InputParameters = InputParameters;
            }
            // to ensure "OutputParameters" is required (not null)
            if (OutputParameters == null)
            {
                throw new InvalidDataException("OutputParameters is a required property for InputOutputAttributes and cannot be null");
            }
            else
            {
                this.OutputParameters = OutputParameters;
            }
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets InputParameters
        /// </summary>
        [DataMember(Name="input_parameters", EmitDefaultValue=false)]
        public Object InputParameters { get; set; }
        /// <summary>
        /// Gets or Sets OutputParameters
        /// </summary>
        [DataMember(Name="output_parameters", EmitDefaultValue=false)]
        public Object OutputParameters { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputOutputAttributes {\n");
            sb.Append("  InputParameters: ").Append(InputParameters).Append("\n");
            sb.Append("  OutputParameters: ").Append(OutputParameters).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InputOutputAttributes);
        }

        /// <summary>
        /// Returns true if InputOutputAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of InputOutputAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputOutputAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InputParameters == other.InputParameters ||
                    this.InputParameters != null &&
                    this.InputParameters.Equals(other.InputParameters)
                ) && 
                (
                    this.OutputParameters == other.OutputParameters ||
                    this.OutputParameters != null &&
                    this.OutputParameters.Equals(other.OutputParameters)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.InputParameters != null)
                    hash = hash * 59 + this.InputParameters.GetHashCode();
                if (this.OutputParameters != null)
                    hash = hash * 59 + this.OutputParameters.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }
    }

}