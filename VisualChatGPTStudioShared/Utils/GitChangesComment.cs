﻿using Community.VisualStudio.Toolkit;
    /// <summary>
    /// Provides functionality to comment on Git changes.
    /// </summary>
    public static class GitChangesComment
        /// <summary>
        /// Retrieves the current changes in the Git repository of the solution, including file changes and their statuses.
        /// </summary>
        public static string GetCurrentChanges()
                //Capture the differences between the HEAD and the working directory
                Patch changes = repo.Diff.Compare<Patch>(repo.Head.Tip.Tree, DiffTargets.WorkingDirectory);

        /// <summary>
        /// Retrieves the file system path of the Git repository that contains the currently opened solution in Visual Studio.
        /// </summary>
        /// <returns>
        /// The file system path of the Git repository containing the solution, or an empty string if the solution is not part of a Git repository.
        /// </returns>
        public static string GetSolutionGitRepositoryPath()