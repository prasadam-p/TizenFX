/*
* Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
*
* Licensed under the Apache License, Version 2.0 (the License);
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an AS IS BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Tizen.Messaging.Email
{
    /// <summary>
    /// The class contains Messaging API to support sending email messages.
    /// </summary>
    public class EmailMessage : IDisposable
    {
        internal IntPtr _emailHandle = IntPtr.Zero;
        private bool _disposed = false;
        private String _subject;
        private String _body;
        private IList<EmailAttachment> _attachments = new List<EmailAttachment>();
        private ICollection<EmailRecipient> _to = new Collection<EmailRecipient>();
        private ICollection<EmailRecipient> _cc = new Collection<EmailRecipient>();
        private ICollection<EmailRecipient> _bcc = new Collection<EmailRecipient>();

        /// <summary>
        /// The constructor
        /// </summary>
        public EmailMessage()
        {
            int ret = Interop.Email.CreateEmail(out _emailHandle);
            if (ret != (int)EmailError.None)
            {
                Log.Error(EmailErrorFactory.LogTag, "Failed to create message handle, Error code: " + (EmailError)ret);
                throw EmailErrorFactory.GetException(ret);
            }
        }

        /// <summary>
        /// Subject of the email message
        /// </summary>
        public string Subject
        {
            set
            {
                _subject = value;
                int ret = Interop.Email.SetSubject(_emailHandle, _subject);
                if (ret != (int)EmailError.None)
                {
                    Log.Error(EmailErrorFactory.LogTag, "Failed to set subject, Error code: " + (EmailError)ret);
                    throw EmailErrorFactory.GetException(ret);
                }
            }
            get
            {
                return _subject;
            }

        }

        /// <summary>
        /// Body of the email message
        /// </summary>
        public string Body
        {
            set
            {
                _body = value;
                int ret = Interop.Email.SetBody(_emailHandle, _body);
                if (ret != (int)EmailError.None)
                {
                    Log.Error(EmailErrorFactory.LogTag, "Failed to set body, Error code: " + (EmailError)ret);
                    throw EmailErrorFactory.GetException(ret);
                }
            }
            get
            {
                return _body;
            }
        }

        /// <summary>
        /// List of file attachments
        /// </summary>
        /// <remarks>
        /// The maximum attachment file size is 10 MB.
        /// </remarks>
        public IList<EmailAttachment> Attachments
        {
            get
            {
                return _attachments;
            }
        }

        /// <summary>
        /// Collection of normal email recipients
        /// </summary>
        /// <remarks>
        /// Email address should be in standard format (as described in Internet standards RFC 5321 and RFC 5322).
        /// </remarks>
        public ICollection<EmailRecipient> To
        {
            get
            {
                return _to;
            }
        }

        /// <summary>
        /// Collection of CC(carbon copy) email recipients
        /// </summary>
        /// <remarks>
        /// Email address should be in standard format (as described in Internet standards RFC 5321 and RFC 5322).
        /// </remarks>
        public ICollection<EmailRecipient> Cc
        {
            get
            {
                return _cc;
            }
        }

        /// <summary>
        /// Collection of BCC(blind carbon copy) email recipients
        /// </summary>
        /// <remarks>
        /// Email address should be in standard format (as described in Internet standards RFC 5321 and RFC 5322).
        /// </remarks>
        public ICollection<EmailRecipient> Bcc
        {
            get
            {
                return _bcc;
            }
        }

        /// <summary>
        /// Saves the email message
        /// </summary>
        public void Save()
        {
            int ret;
            FillHandle();

            ret = Interop.Email.SaveEmail(_emailHandle);
            if (ret != (int)EmailError.None)
            {
                Log.Error(EmailErrorFactory.LogTag, "Failed to save email, Error code: " + (EmailError)ret);
                throw EmailErrorFactory.GetException(ret);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {

            }

            if (_emailHandle != IntPtr.Zero)
            {
                Interop.Email.DestroyEmail(_emailHandle);
                _emailHandle = IntPtr.Zero;
            }
            _disposed = true;
        }

        internal void FillHandle()
        {
            int ret = (int)EmailError.None;
            foreach (EmailAttachment it in Attachments)
            {
                Console.WriteLine(it.FilePath);
                ret = Interop.Email.AddAttachment(_emailHandle, it.FilePath);
                if (ret != (int)EmailError.None)
                {
                    Log.Error(EmailErrorFactory.LogTag, "Failed to add attachment, Error code: " + (EmailError)ret);
                    throw EmailErrorFactory.GetException(ret);
                }
            }

            foreach (EmailRecipient it in To)
            {
                ret = Interop.Email.AddRecipient(_emailHandle, (int)Interop.EmailRecipientType.To, it.Address);
                if (ret != (int)EmailError.None)
                {
                    Log.Error(EmailErrorFactory.LogTag, "Failed to add recipients, Error code: " + (EmailError)ret);
                    throw EmailErrorFactory.GetException(ret);
                }
            }

            foreach (EmailRecipient it in Cc)
            {
                ret = Interop.Email.AddRecipient(_emailHandle, (int)Interop.EmailRecipientType.Cc, it.Address);
                if (ret != (int)EmailError.None)
                {
                    Log.Error(EmailErrorFactory.LogTag, "Failed to add recipients, Error code: " + (EmailError)ret);
                    throw EmailErrorFactory.GetException(ret);
                }
            }

            foreach (EmailRecipient it in Bcc)
            {
                ret = Interop.Email.AddRecipient(_emailHandle, (int)Interop.EmailRecipientType.Bcc, it.Address);
                if (ret != (int)EmailError.None)
                {
                    Log.Error(EmailErrorFactory.LogTag, "Failed to add recipients, Error code: " + (EmailError)ret);
                    throw EmailErrorFactory.GetException(ret);
                }
            }
        }
    }
}
