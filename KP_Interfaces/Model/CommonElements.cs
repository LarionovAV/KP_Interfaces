using Printers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printers
{
    class CommonElements
    {
        public static TreeNode DepTreeRoot { get; private set; }
        public static BindingList<Creator> Creators { get; private set; }
        public static BindingList<MatherialType> MatherialTypes { get; private set; }
        public static BindingList<DeviceType> DeviceTypes { get; private set; }
        public static BindingList<Statement> Statements { get; private set; }

        private CommonElements() { }
        public static void Init() {
            InitDepTree();
            InitCreators();
            InitMatherialTypes();
            InitDeviceTypes();
            InitStatements();
        }

        private static void InitDeviceTypes() {
            DeviceTypes = DeviceType.getDeviceTypes();
            DeviceTypes.Insert(0, new DeviceType(-1, "--Все типы--"));
        }
        private static void InitStatements()
        {
            Statements = Statement.getStatements();
            Statements.Insert(0, new Statement(-1, "--Любое состояние--"));
        }
        private static void InitCreators() {
            Creators = Creator.getCreators();
            Creators.Insert(0, new Creator(-1, "--Все производители--"));
        }

        private static void InitMatherialTypes()
        {
            MatherialTypes = MatherialType.getMatherialTypes();
            MatherialTypes.Insert(0, new MatherialType(-1, "--Все типы--"));
        }
        private static void InitDepTree() {
            DepTreeRoot = new TreeNode("Организация")
            {
                Name = "-1"
            };

            Department.fillTree(DepTreeRoot, -1);
        }

        public static void refreshDepTree() {
            DepTreeRoot.Nodes.Clear();
            Department.fillTree(DepTreeRoot, -1);
        }
    }
}
