properties([disableConcurrentBuilds()])

pipeline {
    
    agent any
    
    options {
        buildDiscarder(logRotator(numToKeepStr: '10', artifactNumToKeepStr: '10'))
        timestamps()
    }
    
    stages {
        stage("Pull") {
            steps {
                sh "rm -rf *"
                git branch: "main", url:"https://github.com/levchenkodanila/jenkins-example"
                buildDescription(sh(returnStdout: true, script: 'git show -s --format="%h %s%n%an"'))
            }
        }
        stage("Test") {
            steps {
                sh "dotnet test MSTest/MSTest.csproj -c Release -o Test"
            }
        }
    }
}