namespace DefaultNamespace
{
    public class SphereApplicationService
    {
        private readonly Sphere _sphere;

        public SphereApplicationService()
        {
            // SphereFactoryが生成すべき気がする
            _sphere = new Sphere();
        }

        public void ChangeSphereMoveDirection(SphereMoveDirection moveDirection)
        {
            _sphere.ChangeMoveDirection(moveDirection);
        }

        public SphereMoveDirection GetMoveDirection()
        {
            return _sphere.MoveDirection;
        }
    }
}