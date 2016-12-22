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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ChangePassword operation.
    /// Changes the password of the IAM user who is calling this action. The root account
    /// password is not affected by this action.
    /// 
    ///  
    /// <para>
    /// To change the password for a different user, see <a>UpdateLoginProfile</a>. For more
    /// information about modifying passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
    /// Passwords</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ChangePasswordRequest : AmazonIdentityManagementServiceRequest
    {
        private string _newPassword;
        private string _oldPassword;

        /// <summary>
        /// Gets and sets the property NewPassword. 
        /// <para>
        /// The new password. The new password must conform to the AWS account's password policy,
        /// if one exists.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of almost any printable ASCII character from the
        /// space (\u0020) through the end of the ASCII character range (\u00FF). You can also
        /// include the tab (\u0009), line feed (\u000A), and carriage return (\u000D) characters.
        /// Although any of these characters are valid in a password, note that many tools, such
        /// as the AWS Management Console, might restrict the ability to enter certain characters
        /// because they have special meaning within that tool.
        /// </para>
        /// </summary>
        public string NewPassword
        {
            get { return this._newPassword; }
            set { this._newPassword = value; }
        }

        // Check to see if NewPassword property is set
        internal bool IsSetNewPassword()
        {
            return this._newPassword != null;
        }

        /// <summary>
        /// Gets and sets the property OldPassword. 
        /// <para>
        /// The IAM user's current password.
        /// </para>
        /// </summary>
        public string OldPassword
        {
            get { return this._oldPassword; }
            set { this._oldPassword = value; }
        }

        // Check to see if OldPassword property is set
        internal bool IsSetOldPassword()
        {
            return this._oldPassword != null;
        }

    }
}