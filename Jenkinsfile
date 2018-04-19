pipeline {
  agent {
    dockerfile {
      filename 'DotNetDockerfile'
    }

  }
  stages {
    stage('TestContainer') {
      steps {
        sh 'cat /etc/*-release'
        sh 'whoami'
        sh 'docker --version'
        sh 'docker ps'
        sh 'docker-compose --version'
      }
    }
    stage('DotNetCore') {
      steps {
        sh 'dotnet --version'
        sh 'dotnet restore Builder.sln'
        sh 'dotnet build Builder.sln'
        sh 'dotnet test Builder.sln'
      }
    }
    stage('Docker') {
      steps {
        sh 'docker-compose build'
      }
    }
  }
}