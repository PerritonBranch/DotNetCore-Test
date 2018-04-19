pipeline {
  agent {
    docker {
      image 'node:6-alpine'
      args '-p 3000:3000'
    }

  }
  stages {
    stage('TestDockerCommands') {
      agent {
        docker {
          image 'node:6-alpine'
          args '-p 3000:3000'
        }

      }
      steps {
        sh 'cat /etc/*-release'
        sh 'whoami'
        sh 'docker ps'
        sh 'docker --version'
        sh 'docker run hello world'
      }
    }
  }
}