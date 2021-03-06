                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                using System.Linq;
using UnityEngine;

namespace UnityEditor.Timeline
{
    class RectangleSelect : RectangleTool
    {
        protected override bool enableAutoPan { get { return false; } }

        protected override bool CanStartRectangle(Event evt, Vector2 mousePosition, WindowState state)
        {
            if (evt.button != 0 || evt.alt)
                return false;

            return PickerUtils.pickedElements.All(e => e is IRowGUI);
        }

        protected override bool On