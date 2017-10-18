﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAction {
  int TpCost();
  int MpCost();
  int MaxDistance();

  string Name();
  string Description();

  bool CanTargetSelf();
  bool NeedsLineOfSight();
  void BeginAction(GameObject targetObject);
  void DoAction(Cursor cursor);
}
