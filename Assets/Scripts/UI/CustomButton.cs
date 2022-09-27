using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class CustomButton : Button {
		public event Action<PointerEventData> onPointerDown;

		public override void OnPointerDown (PointerEventData eventData) {
			base.OnPointerDown (eventData);
			onPointerDown?.Invoke (eventData);
		}
	}
}