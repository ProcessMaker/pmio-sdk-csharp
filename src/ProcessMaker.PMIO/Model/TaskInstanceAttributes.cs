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
    /// TaskInstanceAttributes
    /// </summary>
    [DataContract]
    public partial class TaskInstanceAttributes :  IEquatable<TaskInstanceAttributes>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum INITIAL for "INITIAL"
            /// </summary>
            [EnumMember(Value = "INITIAL")]
            INITIAL,
            
            /// <summary>
            /// Enum DELEGATED for "DELEGATED"
            /// </summary>
            [EnumMember(Value = "DELEGATED")]
            DELEGATED,
            
            /// <summary>
            /// Enum STARTED for "STARTED"
            /// </summary>
            [EnumMember(Value = "STARTED")]
            STARTED,
            
            /// <summary>
            /// Enum CANCELLED for "CANCELLED"
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED,
            
            /// <summary>
            /// Enum FINISHED for "FINISHED"
            /// </summary>
            [EnumMember(Value = "FINISHED")]
            FINISHED,
            
            /// <summary>
            /// Enum COMPLETE for "COMPLETE"
            /// </summary>
            [EnumMember(Value = "COMPLETE")]
            COMPLETE,
            
            /// <summary>
            /// Enum PAUSED for "PAUSED"
            /// </summary>
            [EnumMember(Value = "PAUSED")]
            PAUSED
        }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            
            /// <summary>
            /// Enum _1 for "1"
            /// </summary>
            [EnumMember(Value = "1")]
            _1,
            
            /// <summary>
            /// Enum _2 for "2"
            /// </summary>
            [EnumMember(Value = "2")]
            _2,
            
            /// <summary>
            /// Enum _3 for "3"
            /// </summary>
            [EnumMember(Value = "3")]
            _3,
            
            /// <summary>
            /// Enum _4 for "4"
            /// </summary>
            [EnumMember(Value = "4")]
            _4,
            
            /// <summary>
            /// Enum _5 for "5"
            /// </summary>
            [EnumMember(Value = "5")]
            _5
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstanceAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskInstanceAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstanceAttributes" /> class.
        /// </summary>
        /// <param name="TaskId">TaskId (required).</param>
        /// <param name="InstanceId">InstanceId (required).</param>
        /// <param name="GroupId">GroupId.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="Status">Status (required) (default to &quot;INITIAL&quot;).</param>
        /// <param name="Priority">Priority (required) (default to &quot;3&quot;).</param>
        /// <param name="DelegateDate">DelegateDate.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="FinishDate">FinishDate.</param>
        /// <param name="TaskDueDate">TaskDueDate.</param>
        /// <param name="RiskDate">RiskDate.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="InstanceOverduePercentage">InstanceOverduePercentage.</param>
        /// <param name="Data">Data.</param>
        /// <param name="Content">Content.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        public TaskInstanceAttributes(string TaskId = null, string InstanceId = null, string GroupId = null, string UserId = null, StatusEnum? Status = null, PriorityEnum? Priority = null, string DelegateDate = null, string StartDate = null, string FinishDate = null, string TaskDueDate = null, string RiskDate = null, int? Duration = null, double? InstanceOverduePercentage = null, string Data = null, string Content = null, string CreatedAt = null, string UpdatedAt = null)
        {
            // to ensure "TaskId" is required (not null)
            if (TaskId == null)
            {
                throw new InvalidDataException("TaskId is a required property for TaskInstanceAttributes and cannot be null");
            }
            else
            {
                this.TaskId = TaskId;
            }
            // to ensure "InstanceId" is required (not null)
            if (InstanceId == null)
            {
                throw new InvalidDataException("InstanceId is a required property for TaskInstanceAttributes and cannot be null");
            }
            else
            {
                this.InstanceId = InstanceId;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for TaskInstanceAttributes and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Priority" is required (not null)
            if (Priority == null)
            {
                throw new InvalidDataException("Priority is a required property for TaskInstanceAttributes and cannot be null");
            }
            else
            {
                this.Priority = Priority;
            }
            this.GroupId = GroupId;
            this.UserId = UserId;
            this.DelegateDate = DelegateDate;
            this.StartDate = StartDate;
            this.FinishDate = FinishDate;
            this.TaskDueDate = TaskDueDate;
            this.RiskDate = RiskDate;
            this.Duration = Duration;
            this.InstanceOverduePercentage = InstanceOverduePercentage;
            this.Data = Data;
            this.Content = Content;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name="task_id", EmitDefaultValue=false)]
        public string TaskId { get; set; }
        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name="instance_id", EmitDefaultValue=false)]
        public string InstanceId { get; set; }
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="group_id", EmitDefaultValue=false)]
        public string GroupId { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets DelegateDate
        /// </summary>
        [DataMember(Name="delegate_date", EmitDefaultValue=false)]
        public string DelegateDate { get; set; }
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }
        /// <summary>
        /// Gets or Sets FinishDate
        /// </summary>
        [DataMember(Name="finish_date", EmitDefaultValue=false)]
        public string FinishDate { get; set; }
        /// <summary>
        /// Gets or Sets TaskDueDate
        /// </summary>
        [DataMember(Name="task_due_date", EmitDefaultValue=false)]
        public string TaskDueDate { get; set; }
        /// <summary>
        /// Gets or Sets RiskDate
        /// </summary>
        [DataMember(Name="risk_date", EmitDefaultValue=false)]
        public string RiskDate { get; set; }
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
        /// <summary>
        /// Gets or Sets InstanceOverduePercentage
        /// </summary>
        [DataMember(Name="instance_overdue_percentage", EmitDefaultValue=false)]
        public double? InstanceOverduePercentage { get; set; }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
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
            sb.Append("class TaskInstanceAttributes {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DelegateDate: ").Append(DelegateDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  FinishDate: ").Append(FinishDate).Append("\n");
            sb.Append("  TaskDueDate: ").Append(TaskDueDate).Append("\n");
            sb.Append("  RiskDate: ").Append(RiskDate).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  InstanceOverduePercentage: ").Append(InstanceOverduePercentage).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(obj as TaskInstanceAttributes);
        }

        /// <summary>
        /// Returns true if TaskInstanceAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskInstanceAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskInstanceAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaskId == other.TaskId ||
                    this.TaskId != null &&
                    this.TaskId.Equals(other.TaskId)
                ) && 
                (
                    this.InstanceId == other.InstanceId ||
                    this.InstanceId != null &&
                    this.InstanceId.Equals(other.InstanceId)
                ) && 
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.DelegateDate == other.DelegateDate ||
                    this.DelegateDate != null &&
                    this.DelegateDate.Equals(other.DelegateDate)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.FinishDate == other.FinishDate ||
                    this.FinishDate != null &&
                    this.FinishDate.Equals(other.FinishDate)
                ) && 
                (
                    this.TaskDueDate == other.TaskDueDate ||
                    this.TaskDueDate != null &&
                    this.TaskDueDate.Equals(other.TaskDueDate)
                ) && 
                (
                    this.RiskDate == other.RiskDate ||
                    this.RiskDate != null &&
                    this.RiskDate.Equals(other.RiskDate)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.InstanceOverduePercentage == other.InstanceOverduePercentage ||
                    this.InstanceOverduePercentage != null &&
                    this.InstanceOverduePercentage.Equals(other.InstanceOverduePercentage)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
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
                if (this.TaskId != null)
                    hash = hash * 59 + this.TaskId.GetHashCode();
                if (this.InstanceId != null)
                    hash = hash * 59 + this.InstanceId.GetHashCode();
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.DelegateDate != null)
                    hash = hash * 59 + this.DelegateDate.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.FinishDate != null)
                    hash = hash * 59 + this.FinishDate.GetHashCode();
                if (this.TaskDueDate != null)
                    hash = hash * 59 + this.TaskDueDate.GetHashCode();
                if (this.RiskDate != null)
                    hash = hash * 59 + this.RiskDate.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.InstanceOverduePercentage != null)
                    hash = hash * 59 + this.InstanceOverduePercentage.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }
    }

}
