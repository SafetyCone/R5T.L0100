using System;


namespace R5T.L0100
{
    public class ProjectFilePaths : IProjectFilePaths
    {
        #region Infrastructure

        public static IProjectFilePaths Instance { get; } = new ProjectFilePaths();


        private ProjectFilePaths()
        {
        }

        #endregion
    }
}


namespace R5T.L0100.Strings
{
    public class ProjectFilePaths : IProjectFilePaths
    {
        #region Infrastructure

        public static IProjectFilePaths Instance { get; } = new ProjectFilePaths();


        private ProjectFilePaths()
        {
        }

        #endregion
    }
}


namespace R5T.L0100.All
{
    public class ProjectFilePaths : IProjectFilePaths
    {
        #region Infrastructure

        public static IProjectFilePaths Instance { get; } = new ProjectFilePaths();


        private ProjectFilePaths()
        {
        }

        #endregion
    }
}

namespace R5T.L0100.All.Strings
{
    public class ProjectFilePaths : IProjectFilePaths
    {
        #region Infrastructure

        public static IProjectFilePaths Instance { get; } = new ProjectFilePaths();


        private ProjectFilePaths()
        {
        }

        #endregion
    }
}
