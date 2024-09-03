//go:build nodejs || all
// +build nodejs all

package examples

import (
	"fmt"
	"os"
	"path/filepath"
	"testing"

	"github.com/pulumi/pulumi/pkg/v3/testing/integration"
)

func getJSBaseOptions(t *testing.T) integration.ProgramTestOptions {
	base := getBaseOptions()
	baseJS := base.With(integration.ProgramTestOptions{
		Dependencies: []string{
			"@pulumi/yandex",
		},
	})

	return baseJS
}

func TestAccMyExampleTs(t *testing.T) {
	// check ENV prerequistes
	requiredEnvVars := []string{"YC_TOKEN", "YC_CLOUD_ID", "YC_FOLDER_ID"}
	for _, envVar := range requiredEnvVars {
		value, exists := os.LookupEnv(envVar)
		if !exists || value == "" {
			fmt.Printf("Environment variable %s is missing or empty\n", envVar)
			os.Exit(1)
		}
	}
	test := getJSBaseOptions(t).
		With(integration.ProgramTestOptions{
			Dir: filepath.Join(getCwd(t), "ts"),
		})
	// Available params: https://pkg.go.dev/github.com/pulumi/pulumi/pkg/v3/testing/integration#ProgramTest
	integration.ProgramTest(t, &test)
}
