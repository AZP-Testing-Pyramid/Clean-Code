package org.training.speedrun.stage4;

import org.junit.jupiter.api.Test;
import org.training.speedrun.stage4.Stage4;

import static org.assertj.core.api.Assertions.assertThat;

class Stage4Test {

    private Stage4 stage4 = new Stage4();

    @Test
    void score_is_zero_if_all_the_dice_have_the_same_value() {
        assertThat(stage4.computeScore(1, 1, 1)).isEqualTo(0);
        assertThat(stage4.computeScore(2, 2, 2)).isEqualTo(0);
        assertThat(stage4.computeScore(3, 3, 3)).isEqualTo(0);
        assertThat(stage4.computeScore(4, 4, 4)).isEqualTo(0);
        assertThat(stage4.computeScore(5, 5, 5)).isEqualTo(0);
        assertThat(stage4.computeScore(6, 6, 6)).isEqualTo(0);
    }

    @Test
    void score_is_the_sum_of_dice_multiplied_by_2_if_2_dices_have_the_same_value() {
        assertThat(stage4.computeScore(1, 1, 3)).isEqualTo(10);
        assertThat(stage4.computeScore(4, 3, 3)).isEqualTo(20);
        assertThat(stage4.computeScore(2, 5, 5)).isEqualTo(24);
        assertThat(stage4.computeScore(1, 4, 1)).isEqualTo(12);
    }

    @Test
    void score_is_100_if_dice_are_1_2_3() {
        assertThat(stage4.computeScore(1, 2, 3)).isEqualTo(100);
        assertThat(stage4.computeScore(1, 3, 2)).isEqualTo(100);
        assertThat(stage4.computeScore(2, 1, 3)).isEqualTo(100);
        assertThat(stage4.computeScore(2, 3, 1)).isEqualTo(100);
        assertThat(stage4.computeScore(3, 1, 2)).isEqualTo(100);
        assertThat(stage4.computeScore(3, 2, 1)).isEqualTo(100);
    }

    @Test
    void score_is_the_sum_of_dice_if_no_specific_rules_apply() {
        assertThat(stage4.computeScore(1, 3, 4)).isEqualTo(8);
        assertThat(stage4.computeScore(2, 5, 3)).isEqualTo(10);
        assertThat(stage4.computeScore(4, 6, 2)).isEqualTo(12);
    }
}
