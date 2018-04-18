pipeline {
  agent {
    docker {
      image 'node:6-alpine'
      args '-p 3000:3000'
    }

  }
  stages {
    stage('BuildAndTest') {
      steps {
        sh 'cat /etc/*-release'
        sh 'dotnet restore Builder.sln'
        sh 'dotnet build Builder.sln'
        sh 'dotnet test Builder.sln'
      }
    }
    stage('DockerBuild') {
      steps {
        sh 'docker run hello-world'
      }
    }
  }
}