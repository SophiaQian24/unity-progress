Project Summary (What it does)

1. Basic player movement and camera turning via Transform with Time.deltaTime (frame-rate independent).

2. Input handling using the new Input System: Move (Vector2), Look (Vector2), and Fire (Button).

3. Shooting: instantiate a bullet prefab from a shoot point; bullets move forward and auto-destroy after a delay.

4. Spawning: timed enemy/bullet spawning with InvokeRepeating and stop via CancelInvoke.

5. Minimal gameplay loop: move, look, fire; cursor lock/unlock for FPS-style control.
