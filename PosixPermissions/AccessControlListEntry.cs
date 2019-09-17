﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PosixPermissions
{
    /// <summary>
    /// Contains one POSIX access control list entry.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct AccessControlListEntry
    {
        /// <summary>
        /// The entry tag type.
        /// </summary>
        public AccessControlListEntryTagTypes TagType;

        /// <summary>
        /// The entry tag qualifier (usually user or group ID).
        /// </summary>
        public int TagQualifier;

        /// <summary>
        /// The entry permissions field.
        /// </summary>
        public FilePermissions Permissions;
    }

    /// <summary>
    /// Entry tag types.
    /// </summary>
    public enum AccessControlListEntryTagTypes : int
    {
        /// <summary>
        /// The entry contains permissions for the owning user.
        /// </summary>
        UserObj = 1,

        /// <summary>
        /// The entry contains permissions for a certain user.
        /// </summary>
        User = 2,

        /// <summary>
        /// The entry contains permissions for the owning group.
        /// </summary>
        GroupObj = 3,

        /// <summary>
        /// The entry contains permissions for a certain group.
        /// </summary>
        Group = 4,

        /// <summary>
        /// The entry defines the maximum access permissions mask.
        /// </summary>
        Mask = 5,

        /// <summary>
        /// The entry contains permissions for subjects that do not match any other entry.
        /// </summary>
        Other = 6
    }
}
