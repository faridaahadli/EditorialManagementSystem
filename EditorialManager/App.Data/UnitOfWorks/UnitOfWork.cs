using App.Core.IUnitOfWorks;
using App.Core.Repositories;
using App.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {

        private UserRepository _userRepository;
        public IUserRepository Users =>_userRepository=_userRepository
            ??new UserRepository(_context);

        private ArticleRepository _articleRepository;
        public IArticleRepository Articles => _articleRepository = _articleRepository
            ?? new ArticleRepository(_context);

        private ArticleTypeRepository _articleTypeRepository;
        public IArticleTypeRepository ArticleTypes => _articleTypeRepository = _articleTypeRepository
            ?? new ArticleTypeRepository(_context);

        public IArticleReviewRepository ArticleReviews => throw new NotImplementedException();

        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
