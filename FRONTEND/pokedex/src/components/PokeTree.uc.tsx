import { Tree } from "antd";

export function PokeTree() {

    return (
        <Tree>
            <Tree.TreeNode title="Pokémon" key="0-0">
                <Tree.TreeNode title="Bulbasaur" key="0-0-0" />
                <Tree.TreeNode title="Charmander" key="0-0-1" />
                <Tree.TreeNode title="Squirtle" key="0-0-2" />
            </Tree.TreeNode>
        </Tree>
    );
}