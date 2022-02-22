﻿public enum InputKeys_e
{
    // WASD
    MOVE_FORWARD,
    MOVE_BACKWARD,
    MOVE_LEFT,
    MOVE_RIGHT,

    // Q, E
    ROTATE_LEFT,
    ROTATE_RIGHT,

    // 1-9
    GENERATOR_CELL,
    MOVER_CELL,
    SPINNER_CELL,
    REVERSE_SPINNER_CELL,
    PUSH_CELL,
    SLIDE_CELL,
    ENEMY_CELL,
    TRASH_CELL,
    IMMOVABLE_CELL,

    // C, X, V, DEL
    COPY_SELECTION,
    CUT_SELECTION,
    PASTE_SELECTION,
    DELETE_SELECTION,

    // ARROW KEYS
    MOVE_SELECTION_UP,
    MOVE_SELECTION_DOWN,
    MOVE_SELECTION_LEFT,
    MOVE_SELECTION_RIGHT,

    // SHIFT + ARROW KEY
    SELECTION_STACK,

    // SPACE
    SHOW_DRAGABLE_CELLS,

    // SPACE
    PAUSE_SIMULATION,
}
