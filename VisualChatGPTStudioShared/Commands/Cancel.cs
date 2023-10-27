﻿using Community.VisualStudio.Toolkit;
    /// <summary>
    /// Command to cancel all another commands that is running.
    /// </summary>
    [Command(PackageIds.Cancel)]
        /// <summary>
        /// Executes the command asynchronously.
        /// </summary>
        protected override async System.Threading.Tasks.Task ExecuteAsync(OleMenuCmdEventArgs e)