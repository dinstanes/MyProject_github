using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace MyProject_github
{
    public class MyProject_githubInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "MyProjectgithub";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("ad863053-c927-420b-8478-fba47a328577");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "COWI";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
