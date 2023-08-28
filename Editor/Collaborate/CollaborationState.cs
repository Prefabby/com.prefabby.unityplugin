/*
	Prefabby Unity plugin
    Copyright (C) 2023  Matthias Gall <matt@prefabby.com>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;

using UnityEngine;

namespace Prefabby
{

class PendingSelectionChangesDictionary : SerializableDictionary<string, List<string>>
{
}

[System.Serializable]
class CollaborationState : ScriptableObject
{

	public string collaborationId;
	public string collaborationOwnerId;
	public GameObject collaborationObject;
	public List<TransformCopy> selectionTransforms;
	public PrefabDictionary prefabDictionary;
	public List<Participant> participants;
	public PendingSelectionChangesDictionary pendingSelectionChanges;
	public SerializedTree tree;

}

}
