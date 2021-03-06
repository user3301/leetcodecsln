package gosoln

import (
	"testing"

	"gotest.tools/assert"
)

func TestLengthOfLongestSubstring1(t *testing.T) {
	input := "abcabcbb"
	expected := 3
	actual := LengthOfLongestSubstring(input)
	assert.Equal(t, expected, actual)
}

func TestLengthOfLongestSubstring2(t *testing.T) {
	input := "bbbbbb"
	expected := 1
	actual := LengthOfLongestSubstring(input)
	assert.Equal(t, expected, actual)
}
