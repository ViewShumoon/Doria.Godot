using Godot;
using System;

namespace Doria.Godot.Scenes.Program
{
    public class ProgramLoading : Control
    {
        public int TotalCount;
        public int LoadedCount;

        private readonly AudioManager audioManager;
        private readonly ResourceInteractiveLoader resourceLoader;

       
        private Node root;
        private Node currentScene;
        public override void _EnterTree()
        {
            base._EnterTree();
            
        }

        public override void _Ready()
        {
            root = GetTree().Root;

            currentScene = root.GetChild(GetChildCount() - 1);

            GD.Print("Hello, Godot!");
        }
    }
}
